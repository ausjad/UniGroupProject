#include "GeometeryStream.h"


const GeometeryStream & GeometeryStream::operator << (const vertex_3 & rhs) const {
	glVertex3f(rhs.x, rhs.y, rhs.z);
	
	return *this;
}

const GeometeryStream & GeometeryStream::operator << (const texCoord_2 & rhs) const {
	glTexCoord2f(rhs.x, rhs.y);

	return *this;
}

const GeometeryStream & GeometeryStream::operator << (const normal_3 & rhs) const {
	glNormal3f(rhs.x, rhs.y, rhs.z);

	return *this;
}

const GeometeryStream & GeometeryStream::operator << (const trans_3 & rhs) const {
	glTranslatef(rhs.x, rhs.y, rhs.z);

	return *this;
}

const GeometeryStream & GeometeryStream::operator << (const rot_4 & rhs) const {
	glRotatef(rhs.x, rhs.y, rhs.z, rhs.w);

	return *this;
}

const GeometeryStream & GeometeryStream::operator << (const color_3 & rhs) const {
	glColor3f(rhs.r, rhs.g, rhs.b);

	return *this;
}
 
GeometeryStream & GeometeryStream::operator << (int rhs) {
	GLint polygonMode;

	switch (rhs) {
		case BEGIN_STREAM:
			glPushMatrix();
			break;
		case END_STREAM:
			glPopMatrix();
			break;
		case END_PRIMITIVES:
			glEnd();
			break;
		case START_PRIMITIVE_TRI:
			glBegin(GL_TRIANGLES);
			break;
		case START_ATTRIB:
			glPushAttrib(GL_CURRENT_BIT);
			break;
		case END_ATTRIB:
			glPopAttrib();
			break;
		/*
		case ENFORCE_POLYGON_MODE_SOLID:
			glGetIntegerv(GL_POLYGON_MODE, &polygonMode);
			
			if (polygonMode != GL_FILL) {
				this->polymodeflag = polygonMode;
				glPolygonMode(GL_FRONT_AND_BACK, GL_FILL);
			}
			else {
				polymodeflag = POLY_MODE_CONST;
			}
			break;
		case RESTORE_POLYGON_MODE:
			if (polymodeflag != POLY_MODE_CONST) {
				glPolygonMode(GL_FRONT_AND_BACK, (GLint) polymodeflag);
			}
			break;
			*/
	}

	return *this;
}